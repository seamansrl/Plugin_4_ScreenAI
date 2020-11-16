using System;
using System.IO;

namespace PluginInterface
{
	public interface IPlugin
	{
		IPluginHost Host {get;set;}
		
		string Name {get;}
		string Description {get;}
		string Author {get;}
		string Version {get;}

		String Input { set; }
		String Output { get; }

		MemoryStream Frame { set; }

		System.Windows.Forms.UserControl MainInterface {get;}
		
		void Initialize();
		void Dispose();
	
	}
	
	public interface IPluginHost
	{
		void Feedback(string Feedback, IPlugin Plugin);	
	}
}
