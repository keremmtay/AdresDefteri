﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri.Entities.Concrete
{
    [Table("Users")]
    public class User : BaseEntity
    {
        [Required, DisplayName("Adı"), StringLength(25)]
        public string Name { get; set; }
        [Required, DisplayName("Soyadı"), StringLength(25)]
        public string Surname { get; set; }
        [DisplayName("Profil Fotoğrafı"), StringLength(50), ScaffoldColumn(false)]
        public string UserProfileImage { get; set; }
        [Required, DisplayName("E-Posta"), StringLength(50)]
        public string Email { get; set; }
        [Required, DisplayName("Kullanıcı Adı"), StringLength(50)]
        public string UserName { get; set; }
        [Required, DisplayName("Şifre"), StringLength(25)]
        public string Password { get; set; }
        [DisplayName("Aktif mi?")]
        public bool IsActive { get; set; }
        [DisplayName("Admin mi?")]
        public bool IsAdmin { get; set; }
        [ScaffoldColumn(false)]
        public Guid ActivateGuid { get; set; }  // 1232-asdc-12sd-ss2r

        // İlişkiler

        public List<Address> Addresses { get; set; }
        public List<Liked> Likes { get; set; }
    }
}
