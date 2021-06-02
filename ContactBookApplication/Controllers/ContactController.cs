using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using ContactBookApplication.Entities;
using ContactBookApplication.Models;
using ContactBookApplication.ResourceParameters;
using ContactBookApplication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace ContactBookApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;
        private readonly Cloudinary _cloudinary;
        public ContactController(IContactRepository contactRepository, IMapper mapper, IConfiguration configuration)
        {
            _contactRepository = contactRepository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            Account account = new Account
            {
                Cloud = configuration.GetSection("Cloudinary:CloudName").Value,
                ApiKey = configuration.GetSection("Cloudinary:ApiKey").Value,
                ApiSecret = configuration.GetSection("Cloudinary:ApiSecret").Value,
            };

            _cloudinary = new Cloudinary(account);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> GetContacts([FromQuery] ContactResourceParameters contactResourceParameter)
        {
            var contactsFromRepo = _contactRepository.GetContacts(contactResourceParameter);
            return Ok(_mapper.Map<IEnumerable<ContactDto>>(contactsFromRepo));
        }

        //[Authorize(AuthenticationSchemes = "Bearer", Roles = "Admin")]
        [Authorize(Roles = "Admin")]
        [HttpGet("all-contacts")]
        public ActionResult<IEnumerable<Contact>> GetContactsFromPage([FromQuery] ContactPageResourceParameters contactSearchResourceParameters)
        {
            var contactsFromRepo = _contactRepository.GetContacts(contactSearchResourceParameters);
            return Ok(_mapper.Map<IEnumerable<ContactDto>>(contactsFromRepo));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{contactId}", Name = "GetContact")]
        public ActionResult GetContact(string contactId)
        {
            var contactsFromRepo = _contactRepository.GetContact(contactId);
            return Ok(_mapper.Map<ContactDto>(contactsFromRepo));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult<ContactDto> CreateContact(ContactForCreationDto contact)
        {

            var contactEntity = _mapper.Map<Contact>(contact);
            _contactRepository.AddContact(contactEntity);
            _contactRepository.Save();

            var contactToReturn = _mapper.Map<ContactDto>(contactEntity);
            return CreatedAtRoute("GetContact", new { contactId = contactToReturn.ContactId }, contactToReturn);

        }

        [Authorize(Roles = "Admin")]
        [HttpPatch("photo/{contactId}")]
       public ActionResult UploadPhoto(Guid contactId,[FromForm] PhotoToAddDto photo)
        {

            var contactFromRepo = _contactRepository.GetContact(contactId.ToString());
            if (contactFromRepo == null)
            {
                return Unauthorized();
            }

            var file = photo.PhotoFile;
            if (file.Length <= 0)
            {
                return BadRequest();
            }

            var imageUploadResult = new ImageUploadResult();

            using (var fs = file.OpenReadStream())
            {
                var imageUploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(file.FileName, fs),
                    Transformation = new Transformation().Width(300).Height(300).Crop("fill").Gravity("face")
                };
                imageUploadResult = _cloudinary.Upload(imageUploadParams);
            }

            var publicId = imageUploadResult.PublicId;

            var url = imageUploadResult.Url.ToString();


            var contact = new Contact
            {
                PhotoUrl = url
            };


            if (_contactRepository.UpdatePhoto(contactId, contact))
            {
                return Ok(new { id = publicId, url = url });
            }
            return NotFound();

            

        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{contactId}")]
        public ActionResult UpdateContact(Guid contactId,  ContactForUpdateDto contact)
        {

            var contactFromRepo = _contactRepository.GetContact(contactId.ToString());

            if (contactFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(contact, contactFromRepo);

            _contactRepository.UpdateContact(contactFromRepo);

            _contactRepository.Save();

            return NoContent();

        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{contactId}")]
        public ActionResult DeleteContact(Guid contactId)
        {
            var contactFromRepo = _contactRepository.GetContact(contactId.ToString());
            if (contactFromRepo == null)
            {
                return NotFound();
            }

            _contactRepository.DeleteContact(contactFromRepo);
            _contactRepository.Save();

            return NoContent();
        }


    }
}
