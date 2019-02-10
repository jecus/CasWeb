using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Views;
using Entity.Models;

namespace WebDevelopment.Infrastructude
{
	public class AuthenticationProvider
	{
		public  IIdentity GetIdentity()
		{
				return new Identity()
				{
					Login = "",
					Password = "",
				};
			
		}
	}
}
