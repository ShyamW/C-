using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BindingTest
{
    [Serializable]
    public partial class Plane : Form
	{
		public Plane()
		{
			InitializeComponent();
		}

		BindingSource bsA = new BindingSource(); // Airplanes
		BindingSource bsP = new BindingSource(); // Passengers

		private void Form1_Load(object sender, EventArgs e)
		{
			bsP.ListChanged += new ListChangedEventHandler(bsP_ListChanged);

            Console.WriteLine(Directory.GetCurrentDirectory());
            
            string[] planes = System.IO.File.ReadAllLines("../../planes.txt");
            string[] passengers = System.IO.File.ReadAllLines("../../passengers.txt");


            // Create Airplanes
            Airplane a1, a2, a3;
			bsA.Add(a1 = new Airplane(planes[0], 800));
			bsA.Add(a2 = new Airplane(planes[1], 1023));
			bsA.Add(a3 = new Airplane(planes[2], 67));

            /* Put passengers on these planes */
            int i = 0;
            for (; i < 100; i++)
            {
                a1.Passengers.Add(new Passenger(passengers[i]));
            }

            for (; i < 200; i++)
            {
                a2.Passengers.Add(new Passenger(passengers[i]));
            }

            for (; i < 250; i++)
            {
                a3.Passengers.Add(new Passenger(passengers[i]));
            }

			// Set up data binding for the parent Airplanes
			grid.DataSource = bsA;
			grid.AutoGenerateColumns = true;
			txtModel.DataBindings.Add("Text", bsA, "Model");

			// Set up data binding for the child Passengers
			bsP.DataSource = bsA; // connect the two sources
			bsP.DataMember = "Passengers";
			lstPassengers.DataSource = bsP;
			lstPassengers.DisplayMember = "Name";
			txtName.DataBindings.Add("Text", bsP, "Name");

			// Allow the user to add rows
			((BindingList<Airplane>)bsA.List).AllowNew = true;
			((BindingList<Airplane>)bsA.List).AllowRemove = true;
		}

		void bsP_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.Reset)
				txtName.Enabled = bsP.Current != null;
		}

        private void lstPassengers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

[Serializable]
class Airplane 
{
	public Airplane()
	{
		_id = ++lastID;
	}
	public Airplane(string model, int fuelKg)
	{
		_id = ++lastID; Model = model; _fuelKg = fuelKg;
	}
	private static int lastID = 0;
	public int _id;
	public int ID { get { return _id; } }
	public int _fuelKg;
	public int FuelLeftKg { get { return _fuelKg; } set { _fuelKg = value; } }
	public string _model;
	public string Model { get { return _model; } set { _model = value; } }
	public List<Passenger> _passengers = new List<Passenger>();
	public List<Passenger> Passengers { get { return _passengers; } }
}

[Serializable]
class Passenger
{
	public Passenger(string name)
	{
		_id = ++lastID; Name = name;
	}
	private static int lastID = 0;
	public int _id;
	public int ID { get { return _id; } }
	public string _name;
	public string Name { get { return _name; } set { _name = value; } }
}
