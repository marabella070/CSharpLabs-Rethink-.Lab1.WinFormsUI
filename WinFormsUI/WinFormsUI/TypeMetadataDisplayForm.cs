using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreAPI.Core.Helpers;

namespace WinFormsUI
{
    public partial class TypeMetadataDisplayForm : Form
    {
        public TypeMetadataDisplayForm(Type type)
        {
            InitializeComponent();

            // Using StringBuilder to efficiently form a string
            var sb = new StringBuilder();

            sb.AppendLine($"Type: \"{type}\"\n");

            // Getting and adding information about fields
            List<string> typeFields = ReflectionHelper.GetFieldsInfo(type);
            sb.AppendLine("Fields:");
            sb.AppendLine(typeFields.Any() ? string.Join("\n", typeFields) : "None");

            // Getting information about methods
            List<string> typeMethods = ReflectionHelper.GetMethodsInfo(type);
            sb.AppendLine("\nMethods:");
            sb.AppendLine(typeMethods.Any() ? string.Join("\n", typeMethods) : "None");

            // Getting information about properties
            List<string> typeProperties = ReflectionHelper.GetPropertiesInfo(type);
            sb.AppendLine("\nProperties:");
            sb.AppendLine(typeProperties.Any() ? string.Join("\n", typeProperties) : "None");

            // Getting information about indexers
            List<string> typeIndexers = ReflectionHelper.GetIndexersInfo(type);
            sb.AppendLine("\nIndexers:");
            sb.AppendLine(typeIndexers.Any() ? string.Join("\n", typeIndexers) : "None");

            // TextBox output
            txtBoxTypeMetadata.Text = sb.ToString();
        }
    }
}
