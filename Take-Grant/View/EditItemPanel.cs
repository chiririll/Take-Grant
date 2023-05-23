using System;
using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant.View
{
    public class EditItemPanel
    {
        private const string newItemOption = "Создать";

        private readonly ComboBox itemSelector;

        private readonly Button saveButton;
        private readonly Button deleteButton;

        private AccessModel model;

        public EditItemPanel(ComboBox itemSelector, Button saveButton, Button deleteButton)
        {
            this.itemSelector = itemSelector;

            this.saveButton = saveButton;
            this.deleteButton = deleteButton;

            saveButton.Click += SaveItem;
            deleteButton.Click += DeleteItem;
        }

        public void Init(AccessModel model)
        {
            this.model = model;

            UpdateItems();
        }

        private void SaveItem(object sender, EventArgs e)
        {
            UpdateItems();
        }

        private void CreateItem()
        {

        }

        private void DeleteItem(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            UpdateItems();
        }

        private void UpdateItems()
        {
            itemSelector.Items.Clear();

            foreach (var item in model.Items) 
            {
                itemSelector.Items.Add(item);
            }

            itemSelector.Items.Add(newItemOption);
        }
    }
}
