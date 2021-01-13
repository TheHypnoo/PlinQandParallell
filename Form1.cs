using Newtonsoft.Json;
using PlinQandParallell.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlinQandParallell
{
    public partial class PlinQandParallell : Form
    {
        List<Persona> _users = new List<Persona>();
        Stopwatch timer = new Stopwatch();

        public PlinQandParallell()
        {
            InitializeComponent();
            _users = ReadJSON();
            MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Sequencial();
            timer.Reset();
            Parallel();
        }

        public List<Persona> ReadJSON()
        {
            string json = File.ReadAllText("people.json");
            return JsonConvert.DeserializeObject<List<Persona>>(json);
        }

        private void Sequencial()
        {
            ListViewItem _list;
            string[] _valores;

            timer.Start();

            foreach (Persona _user in _users)
            {
                _valores = sequencial(_user);
                _list = new ListViewItem(_valores[0]);
                _list.SubItems.Add(_valores[1]);
                _list.SubItems.Add(_valores[2]);
                listJson.Items.Add(_list);
            }

            timer.Stop();
            timeS.AppendText(timer.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
        }

        private void Parallel()
        {

            ListViewItem _list;
            string[] _valores;

            timer.Start();

            foreach (Persona _user in _users)
            {
                _valores = parallel(_user);
                _list = new ListViewItem(_valores[0]);
                _list.SubItems.Add(_valores[1]);
                _list.SubItems.Add(_valores[2]);
                listJson2.Items.Add(_list);
            }

            timer.Stop();
            timeP.AppendText(timer.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
        }

        public string[] sequencial(Persona _user)
        {
            string[] _fila = new string[3];

            if (!_user.ComprobarNom())
                _fila[0] = _user.Name;
            else
                _fila[0] = "NO NAME";

            if (_user.ComprobarEmail())
                _fila[1] = _user.email;
            else
                _fila[1] = "NO EMAIL";

            if (_user.ComprobarDNI())
                _fila[2] = _user.dni;
            else
                _fila[2] = "NO DNI";

            return _fila;
        }

        public string[] parallel(Persona _user)
        {
            string[] _fila = new string[3];

            System.Threading.Tasks.Parallel.Invoke(
            () =>
            {
                if (!_user.ComprobarNom())
                    _fila[0] = _user.Name;
                else
                    _fila[0] = "NO NAME";
            },
                 () =>
                 {
                     if (_user.ComprobarEmail())
                         _fila[1] = _user.email;
                     else
                         _fila[1] = "NO EMAIL";
                 },

                 () =>
                 {
                     if (_user.ComprobarDNI())
                         _fila[2] = _user.dni;
                     else
                         _fila[2] = "NO DNI";
                 }
             );

            return _fila;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            listJson.Items.Clear();
            listJson2.Items.Clear();
            timeS.ResetText();
            timeP.ResetText();
            timer.Reset();
        }

        private void btSequencial_Click(object sender, EventArgs e)
        {
            listJson.Items.Clear();
            timeS.ResetText();
            timer.Reset();
            Sequencial();
        }

        private void btParallel_Click(object sender, EventArgs e)
        {
            listJson2.Items.Clear();
            timeP.ResetText();
            timer.Reset();
            Parallel();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheHypnoo");
        }

    }
}
