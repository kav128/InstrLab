using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    /// <summary>
    /// Представляет узел дерева
    /// </summary>
    public class TreeNode
    {
        private readonly List<TreeNode> nextNodes;

        /// <summary>
        /// Последовательность дочерних узлов
        /// </summary>
        public IEnumerable<TreeNode> Next => nextNodes;

        /// <summary>
        /// Получает или задает числовое значение текущего узла
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TreeNode"/> числовым значением
        /// </summary>
        /// <param name="value">Числовое значение узла</param>
        public TreeNode(int value)
        {
            nextNodes = new List<TreeNode>();
            Value = value;
        }

        /// <summary>
        /// Создает новый дочерний узел для текущего узла
        /// </summary>
        /// <param name="value">Числовое значение текущего узла</param>
        /// <returns>Новый узел</returns>
        public TreeNode CreateNext(int value)
        {
            TreeNode node = new TreeNode(value);
            nextNodes.Add(node);
            return node;
        }

        /// <summary>
        /// Десериализует узел из JSON
        /// </summary>
        /// <param name="json">JSON представление узла</param>
        /// <returns>Десериализованный узел</returns>
        public static TreeNode FromJson(string json) => JsonConvert.DeserializeObject<TreeNode>(json);

        /// <summary>
        /// Сериализует узел в JSON
        /// </summary>
        /// <returns>Сериализованный объект JSON</returns>
        public string ToJson() => JsonConvert.SerializeObject(this);

        /// <summary>
        /// Десериализует узел из файла JSON
        /// </summary>
        /// <param name="jsonFile">Имя файла JSON</param>
        /// <returns>Десериализованный узел</returns>
        public static TreeNode FromJsonFile(string jsonFile)
        {
            using (StreamReader sr = new StreamReader(jsonFile))
            {
                string json = sr.ReadToEnd();
                return FromJson(json);
            }
        }

        /// <summary>
        /// Сериализует узел в файл JSON
        /// </summary>
        /// <param name="jsonFile">Имя файла JSON</param>
        public void SaveJson(string jsonFile)
        {
            using (StreamWriter sw = new StreamWriter(jsonFile))
            {
                string json = ToJson();
                sw.WriteLine(json);
            }
        }
    }
}
