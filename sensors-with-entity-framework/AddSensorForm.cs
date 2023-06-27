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
        SensorsForm sensorsForm;

        public AddSensorForm(SensorsForm sensorsForm)
        {
            InitializeComponent();
            this.sensorsForm = sensorsForm;

            cbType.DataSource = getTypes();
            cbUnit.DataSource = getUnits();
        }

        private void btnCancelNewSensor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewSensor_Click(object sender, EventArgs e)
        {
            SensorTypes type = cbType.SelectedItem as SensorTypes;
            MeasurementUnits units = cbUnit.SelectedItem as MeasurementUnits;

            using (var db = new DB_EntityEntities1())
            {
                Sensors sensors = new Sensors
                {
                    Name = txtName.Text,
                    IdSensorTypes = type.Id,
                    IdMeasurementUnits = units.Id,
                };

                db.Sensors.Add(sensors);

                db.SaveChanges();
            }

            sensorsForm.refreshDataGrid();
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
