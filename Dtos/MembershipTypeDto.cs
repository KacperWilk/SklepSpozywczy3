﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepSpozywczy3.Dtos
{
    public class MembershipTypeDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string DiscountRate { get; set; }
    }
}