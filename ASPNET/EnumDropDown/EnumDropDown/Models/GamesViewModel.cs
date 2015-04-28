using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnumDropDown.Models
{
    public class GamesViewModel
    {
        /// <summary>
        /// Some more text
        /// </summary>
        [DisplayName("Handle")]
        public string Name { get; set; }

        /// <summary>
        /// Da game
        /// </summary>
        [Required]
        [DisplayName("Favorite Game")]
        public GameType FavoriteGame { get; set; }


        /// <summary>
        /// Some description here
        /// </summary>
        public enum GameType
        {
            Unknown = 0,
            [Display(Name = "9 ball")]
            NineBall = 1,
            [Display(Name = "10 ball")]
            TenBall = 2,
            [Display(Name = "8 ball")]
            EightBall = 3,
            [Display(Name = "Straight pool")]
            StraightPool = 4,
            [Display(Name = "1 ball")]
            OneBall = 5
        }
    }
}