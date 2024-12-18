﻿using OCoast.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Core.APIDtos.AccountDtos
{
    public class UserDto
    {
        public string UserName { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public Gender Gender { get; set; }
    }
}
