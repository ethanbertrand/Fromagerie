using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class AjoutPermissionDesRoles : Form
    {
        public AjoutPermissionDesRoles()
        {
            InitializeComponent();
            RemplirCBRole();
            RemplirCBPermission();
        }

        private void AjoutPermissionDesRoles_Load(object sender, EventArgs e)
        {

        }

        private void EnregistrerB_Click(object sender, EventArgs e)
        {
            string id = RoleCB.SelectedValue.ToString();
            string id_1 = PermissionCB.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO permission_des_roles(id, id_1) VALUES (@id, @id_1)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@id_1", id_1);

                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show("Enregistrement ajouté avec succès !");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void RemplirCBRole()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, libelle FROM Role";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        RoleCB.DataSource = dt;
                        RoleCB.DisplayMember = "libelle";  // ce qui s'affiche à l'utilisateur
                        RoleCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void RemplirCBPermission()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, libelle FROM Permission";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        PermissionCB.DataSource = dt;
                        PermissionCB.DisplayMember = "libelle";  // ce qui s'affiche à l'utilisateur
                        PermissionCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
    }
}
