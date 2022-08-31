
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Millenium.Mvc.App.Models
{
    public class UserCredentials
{
        [MaxLength(30,ErrorMessageResourceName = "NicknameError", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Nickname", ResourceType = typeof(Resources.Resources))]
        public string Nickname { get; set; }
        [EmailAddress(ErrorMessageResourceName ="EmailError", ErrorMessageResourceType =typeof(Resources.Resources))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }
    }
}