using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ChatASP.ViewModels
{
    public class RegisterModel
    {

        [Required(ErrorMessage ="Не указан логин")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Пароль не указан")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Минимальная длина пароля 6 символов")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
