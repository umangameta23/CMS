﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace callmonitaringsystem2.Models
{
    [Table("Cms_Employee")]
    public class Cms_departmentwithHod
    {
      public int  Cms_Departmentid{get; set;}

      public string Cms_Departmentname { get; set; }

      public string Employee_Name { get; set; }

    }
}