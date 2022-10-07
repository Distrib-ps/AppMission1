using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mission1AP3
{
    public class BaseDeDonnees
    {
        //classe métier centrée les échanges avec la base de données.
       
        //Paramètre de classe sur la connexion
        private MySqlConnection laConnexion;

        public BaseDeDonnees(string nomServeur, string nomBDD , string nomUtilisateur, string MDP)
        {
            //explication de Try et Catch
            try
            {
                
                //construction de la chaine de connexion pour se connecter sur la base de données
                string maChaineConnexion = "";
                {
                     maChaineConnexion = "Server=" + nomServeur + ";Database=" + nomBDD + ";uid=" + nomUtilisateur + ";pwd=" + MDP;
                }
                laConnexion = new MySql.Data.MySqlClient.MySqlConnection();
                laConnexion.ConnectionString = maChaineConnexion;
                laConnexion.Open();
                //on ouvre une connexion à la base de données
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                laConnexion = null;
            }
        }


        public void chargerVille(ListBox uneListe , int nbMaxPraticien)
        {
            //méthode permettant de construire une Liste de Ville à partir des données récupérées depuis la base de données. 
            try
            {
                //on utilise les outils MySQL pour effectuer les requêtes.
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                //on commence par netoyer la liste s'il y a des éléments déjà présent.
                uneListe.Items.Clear();

                uneListe.Items.Add("id nom prenom adresse  coef_notoriete code_type_praticien id_ville");

                maRequete = "SELECT id, nom, prenom, adresse, coef_notoriete, code_type_praticien, id_ville FROM praticien Limit " + nbMaxPraticien;

                maCommande = new MySqlCommand(maRequete, laConnexion);

                mesResultats = maCommande.ExecuteReader();
                //pour chaque Ligne retournée par la requete , nous allons remplir la liste des Villes
                while (mesResultats.Read())
                {
                    uneListe.Items.Add(mesResultats.GetInt32("id") + " | " + mesResultats.GetString("nom") + " | " + mesResultats.GetString("prenom") + " | " + mesResultats.GetString("adresse") + " | " + mesResultats.GetFloat("coef_notoriete") + " | " + mesResultats.GetString("code_type_praticien").ToString() + " | " + mesResultats.GetInt32("id_ville").ToString());
                }
                mesResultats.Close();
            }
            catch (System.Exception erreur)
            {
                uneListe.Items.Add("Erreur");
            }
        }
        public void chargerType(ComboBox uneListe)
        {
            try
            {
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                //on commence par netoyer la liste s'il y a des éléments déjà présent.
                uneListe.Items.Clear();


                maRequete = "SELECT code, libelle FROM `type_praticien`";

                maCommande = new MySqlCommand(maRequete, laConnexion);

                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    uneListe.Items.Add(mesResultats.GetString("code") + " | " + mesResultats.GetString("libelle"));
                    //uneListe.SelectionStart.ToString(mesResultats.GetString("code"));
                }
                uneListe.SelectedIndex = uneListe.Items.Count - 1;
                //pour chaque Ligne retournée par la requete , nous allons remplir la liste des Villes
                mesResultats.Close();
            }
            catch (System.Exception erreur)
            {
                MessageBox.Show("Erreur");
            }
        }
        public void chargerVilles(ComboBox uneListe)
        {
            try
            {
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                //on commence par netoyer la liste s'il y a des éléments déjà présent.
                uneListe.Items.Clear();


                maRequete = "SELECT id, nom FROM `ville` ORDER BY id ASC";

                maCommande = new MySqlCommand(maRequete, laConnexion);

                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    uneListe.Items.Add(mesResultats.GetInt32("id") + " | " + mesResultats.GetString("nom"));
                    //uneListe.SelectionStart.ToString(mesResultats.GetString("code"));
                }
                uneListe.SelectedIndex = uneListe.Items.Count - 1;
                //pour chaque Ligne retournée par la requete , nous allons remplir la liste des Villes
                mesResultats.Close();
            }
            catch (System.Exception erreur)
            {
                MessageBox.Show("Erreur");
            }
        }
        public void ajoutBase(string nom, string prenom, string adresse, double coef, string code_pract, int id_ville)
        {
            //explication de Try et Catch
            try
            {
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                maRequete = "INSERT INTO praticien (nom, prenom, adresse, coef_notoriete, code_type_praticien, id_ville) VALUES(@nom, @prenom, @adresse, @coef_notoriete, @code_type_praticien, @id_ville);";


                maCommande = new MySqlCommand(maRequete, laConnexion);
                maCommande.Parameters.AddWithValue("@nom",nom);
                maCommande.Parameters.AddWithValue("@prenom", prenom);
                maCommande.Parameters.AddWithValue("@adresse", adresse);
                maCommande.Parameters.AddWithValue("@coef_notoriete", coef);
                maCommande.Parameters.AddWithValue("@code_type_praticien", code_pract);
                maCommande.Parameters.AddWithValue("@id_ville", id_ville);
                mesResultats = maCommande.ExecuteReader();
                MessageBox.Show("Praticien ajouté !");
                mesResultats.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erreur");
            }
        }
        public void modifBase(int id, string nom, string prenom, string adresse, double coef, string code_pract, int id_ville)
        {
            //explication de Try et Catch
            try
            {
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                maRequete = "UPDATE praticien SET nom = @nom, prenom = @prenom, adresse = @adresse, coef_notoriete = @coef_notoriete, code_type_praticien = @code_type_praticien, id_ville = @id_ville WHERE id = @id;";


                maCommande = new MySqlCommand(maRequete, laConnexion);
                maCommande.Parameters.AddWithValue("@id", id);
                maCommande.Parameters.AddWithValue("@nom", nom);
                maCommande.Parameters.AddWithValue("@prenom", prenom);
                maCommande.Parameters.AddWithValue("@adresse", adresse);
                maCommande.Parameters.AddWithValue("@coef_notoriete", coef);
                maCommande.Parameters.AddWithValue("@code_type_praticien", code_pract);
                maCommande.Parameters.AddWithValue("@id_ville", id_ville);
                mesResultats = maCommande.ExecuteReader();
                MessageBox.Show("Praticien modifié !");
                mesResultats.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erreur");
            }
        }
        public void suppPraticien(object objetSelect)
        {
            

                string maRequete;
                MySqlCommand maCommande;
                string curItem = objetSelect.ToString();
                string[] id = curItem.Split(" | ");
                string first = id[0];
            try
            {

                maRequete = "DELETE FROM praticien WHERE `id`=" + first;

                maCommande = new MySqlCommand("delPraticienById", laConnexion);
                maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                maCommande.Parameters.Add(new MySqlParameter("theId", first));
                maCommande.ExecuteNonQuery();

            } catch(Exception ex)
            {
                MessageBox.Show("Erreur");
            }
        }
        public void editPraticien(object objetSelect)
        {
            try { 
                string maRequete;
                MySqlCommand maCommande;
                string curItem = objetSelect.ToString();
                string[] split = curItem.Split(" | ");


            }
            catch (System.Exception erreur)
            {
                MessageBox.Show("Erreur");
            }
        }
    }
}
