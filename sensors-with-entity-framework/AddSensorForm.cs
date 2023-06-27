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
    public partial class AddSensorForm : Form
    {
        public AddSensorForm()
        {
            InitializeComponent();

            cbType.DataSource = getTypes();
            cbUnit.DataSource = getUnits();
        }

        private void btnCancelNewSensor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<SensorTypes> getTypes()
        {
            List<SensorTypes> types = null;

            using (var db = new DB_EntityEntities1())
            {
                types = db.SensorTypes.ToList();
            }

            return types;
        }

        private List<MeasurementUnits> getUnits()
        {
            List<MeasurementUnits> units = null;

            using (var db = new DB_EntityEntities1())
            {
                units = db.MeasurementUnits.ToList();
            }

            return units;
        }
    }
}
