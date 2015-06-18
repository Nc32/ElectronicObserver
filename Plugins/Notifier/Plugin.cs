﻿using ElectronicObserver.Window.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicObserver.Window;
using ElectronicObserver.Notifier;
using System.Windows.Forms;

namespace Notifier
{
	public class Plugin : ServerPlugin
	{
		public override string MenuTitle
		{
			get
			{
				return "提醒插件";
			}
		}

		public override async Task<bool> RunService( FormMain main )
		{
			await Task.Run( (Action)( () => NotifierManager.Instance.Initialize( main ) ) );

			return true;
		}

		public override PluginSettingControl GetSettings()
		{
			return new Settings();
		}
	}
}
