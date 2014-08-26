using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEnvEditor
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			__fill_env_vars_list(EnvironmentVariableTarget.User);
		}

		private void lstEnvVars_SelectedIndexChanged(object sender, EventArgs e)
		{
			string envvar_name = (string) lstEnvVars.SelectedItem;
			EnvironmentVariableTarget target = EnvironmentVariableTarget.Machine;

			if(rdoUser.Checked)
				target = EnvironmentVariableTarget.User;

			__file_env_vars_value(target, envvar_name);
		}

		private void rdoUser_CheckedChanged(object sender, EventArgs e)
		{
			__fill_env_vars_list(EnvironmentVariableTarget.User);
		}

		private void rdoSystem_CheckedChanged(object sender, EventArgs e)
		{
			//In the windows settings this is called system
			__fill_env_vars_list(EnvironmentVariableTarget.Machine);
		}

		void __fill_env_vars_list(EnvironmentVariableTarget target)
		{
			lstEnvVars.Items.Clear();

			foreach (DictionaryEntry de in Environment.GetEnvironmentVariables(target))
			{
				lstEnvVars.Items.Add(de.Key);
			}

			if(lstEnvVars.Items.Count > 0)
				lstEnvVars.SelectedIndex = 0;
		}

		void __file_env_vars_value(EnvironmentVariableTarget target, string varname)
		{
			lstEnvVarValues.Items.Clear();

			if(varname == null)
				return;

			string value = Environment.GetEnvironmentVariable(varname, target);

			if (value == null)
				return;
			
			string[] value_split = value.Split(new char[] { ';' });

			foreach (string val in value_split)
			{
				lstEnvVarValues.Items.Add(val);
			}
			return;
		}
	}
}
