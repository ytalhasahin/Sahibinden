using _3_Sahibinden.Context;
using _3_Sahibinden.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3_Sahibinden
{
	public partial class FrmCarAdd : Form
	{
		public FrmCarAdd()
		{
			InitializeComponent();
			cbBrandFill();
			cbColorFill();
		}
		CarsDbContext db = new CarsDbContext();

		public void cbBrandFill()
		{
			cbBrand.DisplayMember = "Name";
			cbBrand.ValueMember = "Id";
			cbBrand.DataSource = db.Brands.ToList();
			/*
            cbBrand.Items.Clear();
            foreach (var brand in db.Brands)
            {
                cbBrand.Items.Add(brand.Name);

            }*/

		}

		public void cbColorFill()
		{
			cbColor.DisplayMember = "Name";
			cbColor.ValueMember = "Id";
			cbColor.DataSource = db.Colors.ToList();
			/*cbColor.Items.Clear();
            foreach (var color in db.Colors)
            {
                cbColor.Items.Add(color.Name);

            }*/
		}

		private void btnAddBrand_Click(object sender, EventArgs e)
		{
			FrmBrandAndColor fbc = new FrmBrandAndColor();
			fbc.isBrand = true;
			fbc.Show();

		}

		private void btnAddColor_Click(object sender, EventArgs e)
		{
			FrmBrandAndColor fbc = new FrmBrandAndColor();
			fbc.isBrand = false;
			fbc.Show();
		}



		private void btnSave_Click(object sender, EventArgs e)
		{
			db.CarAdverts.Add(new CarAdvert { City = txtCity.Text, Km = int.Parse(txtKm.Text), Price = int.Parse(txtPrice.Text), Year = int.Parse(txtYear.Text), Model = txtModel.Text, BrandId = int.Parse(cbBrand.SelectedValue.ToString()), ColorId = int.Parse(cbColor.SelectedValue.ToString()) });
			db.SaveChanges();

		}

		private void btnList_Click(object sender, EventArgs e)
		{
			GridFill();
		}

		private void GridFill()
		{
			var query = from a in db.CarAdverts
						join c in db.Colors on a.ColorId equals c.Id
						join b in db.Brands on a.BrandId equals b.Id
						select new
						{
							ID = a.Id,
							MARKA = b.Name,
							MODEL = a.Model,
							YIL = a.Year,
							KM = a.Km,
							FİYAT = a.Price,
							RENK = c.Name,
							ŞEHİR = a.City
						};
			dgv.DataSource = query.ToList();
		}

		private void FrmCarAdd_Load(object sender, EventArgs e)
		{
			foreach (var item in db.Colors)
			{
				checkedListColor.Items.Add(item.Name);

			}

			foreach (var item in db.Brands)
			{
				checkedListBrand.Items.Add(item.Name);

			}
		}
		bool isShow = false;
		private void btnF_Click(object sender, EventArgs e)
		{


			if (isShow == true)
			{
				while (Width > 624)
				{
					Width -= 2;
				}
				isShow = false;

			}
			else
			{
				while (Width < 950)
				{
					Width += 2;

				}
				isShow = true;
			}
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			int minYear = 0;
			int maxYear = int.MaxValue;
			int minKm = 0;
			int maxKm = int.MaxValue;
			int minPrice = 0;
			int maxPrice = int.MaxValue;

			if (!string.IsNullOrEmpty(txtMinYear.Text))
			{
				minYear = int.Parse(txtMinYear.Text);

			}

			if (!string.IsNullOrEmpty(txtMaxYear.Text))
			{
				maxYear = int.Parse(txtMaxYear.Text);


			}
			if (!string.IsNullOrEmpty(txtMinKm.Text))
			{
				minKm = int.Parse(txtMinKm.Text);


			}
			if (!string.IsNullOrEmpty(txtMaxKm.Text))
			{
				maxKm = int.Parse(txtMaxKm.Text);


			}
			if (!string.IsNullOrEmpty(txtMinPrice.Text))
			{
				minPrice = int.Parse(txtMinPrice.Text);


			}
			if (!string.IsNullOrEmpty(txtMaxPrice.Text))
			{
				maxPrice = int.Parse(txtMaxPrice.Text);


			}
			int index = 0;
			check_colors = new List<string>();
			foreach (var item in checkedListColor.Items)
			{
				if (checkedListColor.CheckedItems.Contains(item))
				{
					check_colors.Add(item.ToString());
					index++;
				}
			}

			if (index == 0)
			{
				foreach (var item in checkedListColor.Items)
				{
					check_colors.Add(item.ToString());
				}
			}
			index = 0;
			check_brands = new List<string>();
			foreach (var item in checkedListBrand.Items)
			{
				if (checkedListBrand.CheckedItems.Contains(item))
				{
					check_brands.Add(item.ToString());
					index++;
				}
			}

			if (index == 0)
			{
				foreach (var item in checkedListBrand.Items)
				{
					check_brands.Add(item.ToString());
				}
			}

			string[] search = new string[2];
			search = txtSearch.Text.Split(',');

			var query = from a in db.CarAdverts
						join c in db.Colors on a.ColorId equals c.Id
						join b in db.Brands on a.BrandId equals b.Id
						where (check_colors.Any(x => x == c.Name) && (check_brands.Any(x => x == b.Name)))
						select new
						{
							ID = a.Id,
							MARKA = b.Name,
							MODEL = a.Model,
							YIL = a.Year,
							KM = a.Km,
							FİYAT = a.Price,
							RENK = c.Name,
							ŞEHİR = a.City
						};
			dgv.DataSource = query.Where(adverts =>
			adverts.KM >= minKm && adverts.KM <= maxKm
			&& adverts.YIL >= minYear && adverts.YIL <= maxYear
			&& adverts.FİYAT >= minPrice && adverts.FİYAT <= maxPrice
			&& search.Count() == 1? (search.Any(s => s == adverts.ŞEHİR) || search.Any(s => adverts.MODEL.Contains(s))) : (search.Any(s => s == adverts.ŞEHİR) && search.Any(s => adverts.MODEL.Contains(s)))
			).ToList();
		}
		List<string> check_colors, check_brands;
		private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CarAdvert carAdvert = db.CarAdverts.Find(dgv.CurrentRow.Cells[0].Value);
			db.CarAdverts.Remove(carAdvert);
			db.SaveChanges();
			GridFill();
		}
	}
}
