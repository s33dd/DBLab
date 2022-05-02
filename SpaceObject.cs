using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab {
  internal class SpaceObject {
    private int id;
    private string name;
    private string description;
    private string type;
    private string location;
    private string photo;

    SpaceObject(int id) {
      this.id = id;
    }
    public int Id {
      get { return id; }
      set { id = value; }
    }
    public string Name {
      get { return name; }
      set { name = value; }
    }
    public string Description {
      get { return description; }
      set { description = value; }
    }
    public string Type {
      get { return type; }
      set { type = value; }
    }
    public string Location {
      get { return location; }
      set { location = value; }
    }
    public string Photo {
      get { return photo; }
      set { photo = value; }
    }
  }
}
