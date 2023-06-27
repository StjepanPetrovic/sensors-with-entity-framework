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

            refreshDataGrid();
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            AddSensorForm addSensorForm = new AddSensorForm(this);

            addSensorForm.ShowDialog();
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            Sensors sensor = dgcSensors.CurrentRow.DataBoundItem as Sensors;

            using (var db = new DB_EntityEntities1())
            {
                db.Sensors.Attach(sensor);

                List<SensorReadings> sensorReadings = db.SensorReadings.ToList().Where(reading => reading.IdSensors == sensor.Id).ToList();

                foreach (SensorReadings item in sensorReadings)
                {
                    db.SensorReadings.Attach(item);
                    db.SensorReadings.Remove(item);
                }

                db.Sensors.Remove(sensor);

                db.SaveChanges();
            }

            refreshDataGrid();
        }

        public List<Sensors> getSensors()
        {
            List<Sensors> sensors = null;

            using (var db = new DB_EntityEntities1())
            {
                sensors = db.Sensors.ToList();
            }

            return sensors;
        }

        public void refreshDataGrid()
        {
            dgcSensors.DataSource = getSensors();
            dgcSensors.Columns[4].Visible = false;
            dgcSensors.Columns[5].Visible = false;
            dgcSensors.Columns[6].Visible = false;
        }
    }
}
