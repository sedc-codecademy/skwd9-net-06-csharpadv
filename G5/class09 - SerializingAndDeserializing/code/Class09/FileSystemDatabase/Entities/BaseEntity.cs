using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemDatabase.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
