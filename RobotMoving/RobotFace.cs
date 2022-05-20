using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RobotMoving
{
    public enum  RobotFace
    {
        [Display(Name = "UNKNOWN")]
        UNKNOWN,
        [Display(Name = "NORTH")]
        NORTH,
        [Display(Name = "NORTH WEST")]
        NORTH_WEST,
        [Display(Name = "WEST")]
        WEST,
        [Display(Name = "SOUTH EAST")]
        SOUTH_EAST,
        [Display(Name = "SOUTH")]
        SOUTH,
        [Display(Name = "SOUTH WEST")]
        SOUTH_WEST,
        [Display(Name = "EAST")]
        EAST,
        [Display(Name = "NORTH EAST")]
        NORTH_EAST
    }
}
