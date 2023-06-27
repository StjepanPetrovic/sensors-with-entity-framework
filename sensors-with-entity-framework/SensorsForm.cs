using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sensors_with_entity_framework
{
    public partial class SensorsForm : Form
    {
        public SensorsForm()
        {
            InitializeComponent();

        public List<Sensors> getSensors()
        {
            List<Sensors> sensors = null;

            using (var db = new DB_EntityEntities())
            {
                sensors = db.Sensors.ToList();
            }

            return sensors;
        }
        }
    }
}
