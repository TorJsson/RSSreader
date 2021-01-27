using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleLayer;
using DataLayer;
using System.Linq;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private FeedsMethods feedsMethods = new FeedsMethods();
        private Episodes episode;
        private List<string> CategoryList = new List<string>();
        private UrlValidate urlValidator = new UrlValidate();
        private TextValidate textValidator = new TextValidate();
        private ComboboxValidate comboboxValidator = new ComboboxValidate();

        public Form1()
        {
            InitializeComponent();
            cboxUpdateFrequency.Items.Add("1 min");
            cboxUpdateFrequency.Items.Add("5 min");
            cboxUpdateFrequency.Items.Add("10 min");
            ((DataGridViewComboBoxColumn)gridFeed.Columns["Frequencys"]).Items.Add("1 min");
            ((DataGridViewComboBoxColumn)gridFeed.Columns["Frequencys"]).Items.Add("5 min");
            ((DataGridViewComboBoxColumn)gridFeed.Columns["Frequencys"]).Items.Add("10 min");

            CategoryList = CategoryStorage.GetCategories();
            CategorySerializer categoryMethods = new CategorySerializer();
            UpdateCategoryList();
            UpdateFeed();

        }

        private void UpdateFeed()
        {
            gridFeed.Rows.Clear();
            List<Feeds> feedList = feedsMethods.RetrieveAllFeeds();
            try
            {
                foreach (var feed in feedList)
                {
                    int row = gridFeed.Rows.Add();
                    gridFeed.Rows[row].Cells["Title"].Value = feed.GetTitle();
                    gridFeed.Rows[row].Cells["Frequencys"].Value = feed.FeedUpdateIntervall;
                    gridFeed.Rows[row].Cells["Avsnitt"].Value = feed.EpisodeList.Count;
                    gridFeed.Rows[row].Cells["Category"].Value = feed.FeedCategories.CategoryName;
                    gridFeed.Rows[row].Tag = feed;

                }
            }
            catch (NullReferenceException)
            {
                return;
            }
         
        }

        private void UpdateFeed(String categoryChosen)
        {
            gridFeed.Rows.Clear();
            List<Feeds> feedsList = feedsMethods.RetrieveAllFeeds();
            List<Feeds> feeden = feedsList.Where(x => x.FeedCategories.CategoryName.Equals(categoryChosen))
                                          .Select(x => x).ToList();
            try
            {
                foreach (var feed in feeden)
                {
                    int rad = gridFeed.Rows.Add();
                    gridFeed.Rows[rad].Cells["Title"].Value = feed.FeedTitle;
                    gridFeed.Rows[rad].Cells["Frequencys"].Value = feed.FeedUpdateIntervall;
                    gridFeed.Rows[rad].Cells["Avsnitt"].Value = feed.EpisodeList.Count;
                    gridFeed.Rows[rad].Cells["Category"].Value = feed.FeedCategories.CategoryName;
                    gridFeed.Rows[rad].Tag = feed;

                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {

            try
            {

                textValidator.ValideraInput(txtBoxName.Text);
                urlValidator.ValidateInput(txtBoxURL.Text);
                comboboxValidator.ValideraInput((string)cbCategory.SelectedItem);
                comboboxValidator.ValideraInput(cboxUpdateFrequency.SelectedItem.ToString());


                String addedName = txtBoxName.Text.Trim();
                string loadedUrl = txtBoxURL.Text.Trim();
                String updateFrequency = cboxUpdateFrequency.SelectedItem.ToString();
                Categories kategori = new Categories(cbCategory.SelectedItem.ToString());

                feedsMethods.FeedController(addedName, loadedUrl, updateFrequency, kategori);
                UpdateFeed();
                txtBoxURL.Clear();
                txtBoxName.Clear();
                

            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string category = lbCategory.SelectedItem?.ToString();
                textCategory.Text = category;
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
           
            try
            {
                textValidator.ValideraInput(textCategory.Text);
                var oldValue = lbCategory.SelectedItem.ToString();
                var newvalue = textCategory.Text;
                int index = CategoryList.IndexOf(oldValue);             
                if (index != -1)
                    
                {                   
                    CategoryList[index] = newvalue; 
                }
                UpdateCategoryOnFeeds(oldValue, newvalue);
                UpdateCategoryList();
                UpdateFeed();

                CategoryStorage.SaveCategories(CategoryList);
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }

        }

        private void UpdateCategoryOnFeeds(string oldvalue, string newvalue)
        {
            try
            {
                var index = 0;
                while (index >= 0)
                {
                    List<Feeds> feedsList = feedsMethods.RetrieveAllFeeds();
                    index = feedsList.FindIndex(x => x.FeedCategories.CategoryName.Equals(oldvalue));
                                      
                    foreach (var feed in feedsList)
                    {
                        if (feed.FeedCategories.CategoryName == (String)oldvalue)
                        {
                            feed.FeedCategories.CategoryName = newvalue;
                            feedsMethods.UpdateFeeden(index, feed);
                        }

                        if (index == -1)
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {

            try
            {
                var choosenCategory = lbCategory.SelectedItem.ToString();

                string message = "This will also remove all podcasts with this category assigned, are you sure you want to do that?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    LoopListToDeleteFeedsByCategory(choosenCategory);
                    CategoryList.Remove(choosenCategory);
                    UpdateCategoryList();
                    CategoryStorage.SaveCategories(CategoryList);

                }
                else
                {
                    return;
                }
            }

            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }

        private void addCategory_Click_1(object sender, EventArgs e)
        {
            try
            {
                textValidator.ValideraInput(textCategory.Text);

                var kategori = textCategory.Text;
                if (!CategoryList.Contains(kategori))
                {
                    CategoryList.Add(kategori);
                }
                UpdateCategoryList();
                CategoryStorage.SaveCategories(CategoryList);
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }

        private void UpdateCategoryList()
        {
            try
            {
                lbCategory.Items.Clear();
                cbCategory.Items.Clear();
                ((DataGridViewComboBoxColumn)gridFeed.Columns["Category"]).Items.Clear();

                foreach (var kategori in CategoryList)
                {
                    lbCategory.Items.Add(kategori);
                    cbCategory.Items.Add(kategori);
                    ((DataGridViewComboBoxColumn)gridFeed.Columns["Category"]).Items.Add(kategori);

                }

                textCategory.Clear();
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }

        }

        private void lbEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
           try {
                if (lbEpisodes.SelectedItems.Count == 0)
                {
                    return;
                }
                if (lbEpisodes.SelectedItems[0] != null)
                {
                    var feed = (Episodes)lbEpisodes.SelectedItems[0];
                    episode = feed;
                    string title = episode.GetTitle();
                    string description = episode.EpisodeDescription;
                    lblAvsnitt.Text = title;
                    txtBoxDescription.Text = description;
                  

                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }

        private void gridFeed_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridFeed.SelectedRows.Count != 0)
                {
                    Feeds feed = (Feeds)gridFeed.SelectedRows[0].Tag;
                    GetEpisodes(feed.EpisodeList);
                }
            }
            catch (NullReferenceException)
            { return; }
        }

        private void GetEpisodes(List<Episodes> episodeList)
        {
            try
            {
                lbEpisodes.Items.Clear();

                if (episodeList != null)
                {
                    foreach (Episodes episode in episodeList)
                    {
                        lbEpisodes.Items.Add(episode);

                    }

                }
            }
            catch (NullReferenceException)
            { return; }

        }

        private void gridFeed_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridFeed.Rows.Count < 0)
                {
                    return;
                }
                if (e.RowIndex < 0)
                {
                    return;
                }
                var rad = gridFeed.Rows[e.RowIndex];
                if (rad.Tag == null)
                {
                    return;
                }

                int rowIndex = gridFeed.Rows[e.RowIndex].Index;
                Feeds valdCell = (Feeds)gridFeed.Rows[rowIndex].Tag;
                var feed = (Feeds)rad.Tag;
                feed.FeedTitle = (String)rad.Cells["Title"].Value;
                feed.FeedUpdateIntervall = (String)rad.Cells["Frequencys"].Value;
                feed.FeedCategories.CategoryName = (String)rad.Cells["Category"].Value;
                feedsMethods.UpdateFeeden(rowIndex, feed);
                gridFeed.Rows.Clear();
                UpdateFeed();
            }
            catch (NullReferenceException)
            { return; }
        }

        private void LoopListToDeleteFeedsByCategory(string categoryChoosen)
        {
            try
            {
                int index = 0;
                while (index >= 0)
                {
                    index = DeleteCategoryAndPodcast(categoryChoosen);
                }
            }
            catch (NullReferenceException)
            { return; }
        }

        private int DeleteCategoryAndPodcast(string choosenCategory)
        {

            List<Feeds> feedsList = feedsMethods.RetrieveAllFeeds();
            var index = feedsList.FindIndex(x => x.FeedCategories.CategoryName.Equals(choosenCategory));
            if (index == -1)
            {
                return index;
            }
            feedsMethods.DeleteFeed(index);
            UpdateFeed();
            return index;
        }


        private void btnRemovedMarkedPodcast_Click(object sender, EventArgs e)
        {
            try { 
            if (gridFeed.SelectedRows.Count < 1)
            {
                MessageBox.Show("Click on a row to remove the podcast!");
                return;
            }
            if (gridFeed.SelectedRows[0] == null)
            {
                return;
            }
            int rowIndex = gridFeed.SelectedRows[0].Index;
            Feeds choosenPodcast = (Feeds)gridFeed.Rows[rowIndex].Tag;
            feedsMethods.DeleteFeed(rowIndex);
            lbEpisodes.Items.Clear();
            UpdateFeed();
            }
            
            catch (NullReferenceException)
            { return; }
        }

        public void btnShowPodcastByCategory_Click(object sender, EventArgs e)
        {
            try
            {
                String categoryChosen = (String)cbCategory.SelectedItem;
                UpdateFeed(categoryChosen);
            }
            catch (NullReferenceException)
            { return; }
        }

        private void gridFeedCurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewColumn column = gridFeed.Columns[gridFeed.CurrentCell.ColumnIndex];
                if (column is DataGridViewComboBoxColumn)
                {
                    gridFeed.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (NullReferenceException)
            { return; }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UpdateFeed();
        }
        private void gridFeed_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
