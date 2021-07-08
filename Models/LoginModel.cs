using System.ComponentModel.DataAnnotations;

namespace Tm2TestAppService.Models
{
    public class LoginModel
    {
        /// <summary>
        /// ログインID
        /// </summary>
        [Display(Name = "ログインID")]
        public string Id { get; set; }

        /// <summary>
        /// ログインパスワード
        /// </summary>
        [Display(Name = "パスワード")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// このアカウントを記憶する
        /// </summary>
        [Display(Name = "このアカウントを記憶する")]
        public bool RememberMe { get; set; }
    }
}