using System;

public partial class Controls_TunerUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed_Click(object sender, EventArgs e)
    {
        string ID = this.Listbox.SelectedValue;
        string list1 = this.Listbox1.SelectedItem.Text;
        string list2 = this.Listbox2.SelectedItem.Text;
        string list3 = this.Listbox3.SelectedItem.Text;
        string list4 = this.Listbox4.SelectedItem.Text;
        string list5 = this.Listbox5.SelectedItem.Text;
        string list6 = this.Listbox6.SelectedItem.Text;

       Global.TunerDB.InstrumentTunerRepository.LogNotes(list1, list2, list3, list4, list5, list6, ID);
    }

    public void SelectInstrumentListBox(int ID)
    {
        string TextField = this.Listbox.DataTextField = "Name";
        string ValueField = this.Listbox.DataValueField = "ID";
        this.Listbox.DataSource = Global.TunerDB.InstrumentRepository.DataTable(Global.TunerDB.InstrumentRepository.SelectInstrumentListBox(ID));
        this.Listbox.DataBind();
    }

    public void SelectNotes()
    {
        this.Listbox1.DataTextField = this.Listbox2.DataTextField =
        this.Listbox3.DataTextField = this.Listbox4.DataTextField =
        this.Listbox5.DataTextField = this.Listbox6.DataTextField = "Name";

        this.Listbox1.DataValueField = this.Listbox2.DataValueField =
        this.Listbox3.DataValueField = this.Listbox4.DataValueField =
        this.Listbox5.DataValueField = this.Listbox6.DataValueField = "ID";


        this.Listbox1.DataSource = this.Listbox2.DataSource =
        this.Listbox3.DataSource = this.Listbox4.DataSource =
        this.Listbox5.DataSource = this.Listbox6.DataSource = Global.TunerDB.NoteRepository.DataTable(Global.TunerDB.NoteRepository.SelectNotes());

        this.Listbox1.DataBind();
        this.Listbox2.DataBind();
        this.Listbox3.DataBind();
        this.Listbox4.DataBind();
        this.Listbox5.DataBind();
        this.Listbox6.DataBind();

    }

}