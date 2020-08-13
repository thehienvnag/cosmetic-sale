using System.Data;

namespace CSharpAssignment.Models
{
    public class Common
    {
        public Common()
        {

        }

        public int IsExistItemInShoppingCart(string itemID, DataTable dataTable)
        {
            int indexOfRow = -1;
            for (int dataRow = 0; dataRow < dataTable.Rows.Count; dataRow++)
            {
                if (dataTable.Rows[dataRow]["ID"].ToString() == itemID)
                {
                    indexOfRow = dataRow;
                    break;
                }
            }
            return indexOfRow;
        }
    }
}