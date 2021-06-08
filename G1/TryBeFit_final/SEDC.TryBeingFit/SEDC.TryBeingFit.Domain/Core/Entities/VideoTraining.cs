using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public class VideoTraining : Training, IVideoTraining
	{
		public string Link { get; set; }

		public override string Print()
		{
            return $"[{Difficulty}] {Title} - {Description}";
		}
	}
}
