using System.Text;

namespace Blind75CSharp.Week06;

public class FileSystem
{
   private readonly File _root = new();

   public IList<string> Ls(string path)
   {
      var paths = path.Split('/');
      if (paths.Length == 2 && paths[1] == string.Empty) return _root.Files.Keys.ToList();

      var current = _root;
      for (var i = 1; i < paths.Length - 1; i++)
      {
         current = current.Files[paths[i]];
      }

      if (current.isFile) return new List<string> {current.Content.ToString()};

      var result = current.Files[paths[^1]].Files
         .OrderBy(x => x.Key)
         .Select(kp => kp.Key)
         .ToList();

      return result;
   }

   public void Mkdir(string path)
   {
      var current = _root;
      var paths = path.Split('/');

      for (var i = 1; i < paths.Length; i++)
      {
         var p = paths[i];
         if (!current.Files.ContainsKey(p))
         {
            current.Files.Add(p, new File());
         }

         current = current.Files[p];
      }
   }

   public void AddContentToFile(string filePath, string content)
   {
      var current = _root;
      var paths = filePath.Split('/');
      for (var i = 1; i < paths.Length - 1; i++)
      {
         current = current.Files[paths[i]];
      }

      var lastPath = paths[^1];

      if (!current.Files.ContainsKey(lastPath))
      {
         current.Files.Add(lastPath, new File {isFile = true});
      }

      current.Files[lastPath].Content.Append(content);
   }

   public string ReadContentFromFile(string filePath)
   {
      var current = _root;

      var paths = filePath.Split('/');
      for (var i = 1; i < paths.Length; i++)
      {
         current = current.Files[paths[i]];
      }

      return current.Content.ToString();
   }
}

public class File
{
   public bool isFile { get; set; } = false;
   public StringBuilder Content { get; } = new StringBuilder();
   public Dictionary<string, File> Files { get; } = new();
}