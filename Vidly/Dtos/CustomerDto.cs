﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.ValidationModels;

namespace Vidly.Dtos
{
	public class CustomerDto
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		//[Min18YearsIfAMember]
		public DateTime? BirthDate { get; set; }
		
		public bool IsSubscribedToNewsLetter { get; set; }

		[Required]
		public byte MembershipTypeId { get; set; }

	}
}