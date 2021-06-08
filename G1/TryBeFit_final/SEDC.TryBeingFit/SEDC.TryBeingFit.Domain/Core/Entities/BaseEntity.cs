using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public abstract class BaseEntity : IBaseEntity
	{
		public int Id { get; set; }
		public abstract string Print();
	}
}
