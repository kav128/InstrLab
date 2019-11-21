using System.IO;
using System.Xml.Serialization;

namespace Lab1
{
    /// <summary>Представляет дерево</summary>
    public class Tree
    {
        /// <summary>
        /// Возвращает корневой узел дерева
        /// </summary>
        public TreeNode Root { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tree"/>
        /// </summary>
        /// <param name="rootValue">Значение крневого узла дерева</param>
        public Tree(int rootValue) => Root = new TreeNode(rootValue);

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tree"/>
        /// </summary>
        public Tree() => Root = new TreeNode();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tree"/>
        /// </summary>
        /// <param name="json">JSON представление коневого узла</param>
        public Tree(string json) => Root = TreeNode.FromJson(json);

        /// <summary>
        /// Очищает дерево и записывает нуль в корневой элемент
        /// </summary>
        public void Clear() => Root = new TreeNode();

        /// <summary>
        /// Сериализует дерево в файл JSON
        /// </summary>
        /// <param name="jsonFile">Имя файла JSON</param>
        public void SaveJson(string jsonFile) => Root.SaveJson(jsonFile);

        /// <summary>
        /// Сериализует дерево в файл XML
        /// </summary>
        /// <param name="xmlFile">Имя файла XML</param>
        public void SaveXml(string xmlFile) => Root.SaveXml(xmlFile);

        /// <summary>
        /// Загружает дерево из XML файла
        /// </summary>
        /// <param name="xmlFile">Имя файла XML</param>
        public void LoadFromXML(string xmlFile)
        {
            using Stream stream = new FileStream(xmlFile, FileMode.Open, FileAccess.Read, FileShare.None, 4096);
            XmlSerializer serializer = new XmlSerializer(typeof(TreeNode));
            TreeNode node = serializer.Deserialize(stream) as TreeNode;
            Root = node;
        }
    }
}
