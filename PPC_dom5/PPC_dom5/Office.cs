using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_dom5
{
	public enum OfficeSizes : ushort
	{
		small = 0,
		medium = 1,
		large = 2
	}
	public class Office
	{
		public uint Size;
		public uint Building;
		public uint Room;
		public static explicit operator OfficeUnit(Office o)
		{
			OfficeUnit ou;
			if (o.Size <= 64) ou.Size = OfficeSizes.small;
			else
	if (o.Size > 64 && o.Size < 100) ou.Size = OfficeSizes.medium;
			else
				ou.Size = OfficeSizes.large;
			ou.Building = o.Building;
			ou.Room = o.Room;
			return ou;
		}
		public override int GetHashCode()
		{   //Room numbers are no larger than 4 digits
			//Therefore multiply building number by 10000
			//to add in room number and generate unique number
			return (int)(Building * 10000 + Room);
		}
		public override string ToString()
		{ return String.Concat(Building, "/", Room); }

		public override bool Equals(Object objOffice)
		{
			Office o = (Office)objOffice;
			if (o.Size != this.Size) return false;
			if (o.Building != this.Building) return false;
			if (o.Room != this.Room) return false;
			return true;
		}
		static public bool operator ==(Office o1, Office o2)
		{ return Equals(o1, o2); }
		static public bool operator !=(Office o1, Office o2)
		{ return !Equals(o1, o2); }
	}
	public struct OfficeUnit
	{
		public OfficeSizes Size;
		public uint Building;
		public uint Room;
	}

}
