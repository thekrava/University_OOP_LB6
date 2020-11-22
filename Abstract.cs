using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KravchenkoD2_12FIT6
{
	abstract class AbstractHandler
	{
		public abstract void Open(string path);
		public abstract void Create(string path);
		public abstract void Edit(params object[] settings);
	}
}