using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mission1AP3
{
    class BaseDeDonnees
    {
        //classe métier centrée les échanges avec la base de données.
       
        //Paramètre de classe sur la connexion
        private MySqlConnection laConnexion;

        public BaseDeDonnees(string nomServeur, string nomBDD, string numeroPort, string nomUtilisateur, string MDP)
        {
            //explication de Try et Catch
            try
            {
                
                //construction de la chaine de connexion pour se connecter sur la base de données
                string maChaineConnexion = "";
                {
                     maChaineConnexion = "server=" + nomServeur + ";Database=" + nomBDD + ";port=" + numeroPort + ";uid=" + nomUtilisateur + ";pwd=" + MDP;
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
                    uneListe.Items.Add(mesResultats.GetInt32("id") + " " + mesResultats.GetString("nom") + " " + mesResultats.GetString("prenom") + " " + mesResultats.GetString("adresse") + " " + mesResultats.GetFloat("coef_notoriete") + " " + mesResultats.GetString("code_type_praticien").ToString() + " " + mesResultats.GetInt32("id_ville").ToString());
                }
                mesResultats.Close();
            }
            catch (System.Exception erreur)
            {
                uneListe.Items.Add("Erreur");
            }
        }
        public void suppPraticien(object objetSelect)
        {
            

                string maRequete;
                MySqlCommand maCommande;
                string curItem = objetSelect.ToString();
                string[] id = curItem.Split(' ');
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
    }
}
