using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYEDASWEBAPP_REV0
{
    public class Analog
    {
        public List<AnalogValue> Analogs(List<string> Analog_Paths)
        {
            List<AnalogValue> Analog_Items = new List<AnalogValue>();

            //Scadaya bağlan//
            //IxScriptComponent m_ScriptingComponent = new ScadaScriptComponent();
            //m_ScriptingComponent.ContextName = "RT";
            //m_ScriptingComponent.UserName = Environment.UserName;
            //m_ScriptingComponent.ConsoleName = Environment.MachineName;
            //m_ScriptingComponent.SetActive(0);
            //Scadaya bağlan//

            foreach (var item in Analog_Paths)
            {
                AnalogMeasurement analogmeasurement = new AnalogMeasurement();
                analogmeasurement.ObjectPath = item;
                analogmeasurement.FetchValue =  5;
                Analog_Items.Add(new AnalogValue() { Path = item, Value = analogmeasurement.FetchValue });
            }
            return Analog_Items;

        }
    }
}
