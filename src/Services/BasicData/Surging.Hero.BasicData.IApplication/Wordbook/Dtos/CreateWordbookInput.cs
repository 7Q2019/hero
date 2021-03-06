﻿using Surging.Hero.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Surging.Hero.BasicData.IApplication.Wordbook.Dtos
{
    public class CreateWordbookInput : WordbookDtoBase
    {
        [Required(ErrorMessage = "字典编码不允许为空")]
        [RegularExpression(RegExpConstants.WordbookCode, ErrorMessage = "字典类型编码格式不正确")]
        public string Code { get; set; }
    }
}
