using System;
using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant.View
{
    public class EditItemPanel
    {
        private const string newItemOption = "*Добавить...";

        private readonly ComboBox itemSelector;

        private readonly TextBox nameField;

        private readonly Button saveButton;
        private readonly Button deleteButton;

        private AccessModel model;

        public EditItemPanel(
            ComboBox itemSelector,
            TextBox nameField,
            Button saveButton,
            Button deleteButton)
        {
            this.itemSelector = itemSelector;

            this.nameField = nameField;

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
            var item = itemSelector.SelectedItem as Item;

            if (item == null)
            {
                CreateItem();
            }
            else
            {
                EditItem(item);
            }

            UpdateItems();
        }

        private void CreateItem()
        {
            model.CreateItem(nameField.Text);
        }

        private void EditItem(Item item)
        {
            item.Name = nameField.Text;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            UpdateItems();
        }

        private void UpdateItems()
        {
            var prevIndex = itemSelector.SelectedIndex;
            itemSelector.Items.Clear();

            foreach (var item in model.Items) 
            {
                itemSelector.Items.Add(item);
            }

            itemSelector.Items.Add(newItemOption);

            itemSelector.SelectedIndex = M.Clamp(prevIndex, 0, itemSelector.Items.Count - 1);
        }
    }
}
