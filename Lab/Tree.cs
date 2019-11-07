namespace Lab1
{
    /// <summary>Представляет дерево</summary>
    public class Tree
    {
        /// <summary>
        /// Возвращает корневой узел дерева
        /// </summary>
        public TreeNode Root { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tree"/>
        /// </summary>
        /// <param name="rootValue">Значение крневого узла дерева</param>
        public Tree(int rootValue) => Root = new TreeNode(rootValue);

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tree"/>
        /// </summary>
        /// <param name="json">JSON представление коневого узла</param>
        public Tree(string json) => Root = TreeNode.FromJson(json);
    }
}
