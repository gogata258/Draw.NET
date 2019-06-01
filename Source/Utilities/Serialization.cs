using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PaintNET.Utilities
{
	using Shapes;
	using Shapes.Abstracts;

	public static class Serialization
	{
		internal static List<ShapeBase> DeserializeShapes(List<JToken> list)
		{
			var shapes = new List<ShapeBase>( );
			var temp = new Group("empty", new List<ShapeBase>());
			string typeKey = nameof(temp.ShapeType);
			string shapesKey = nameof(temp.Shapes);

			foreach (JObject item in list)
			{
				string foundTypeName = item[typeKey].Value<string>();
				Type type = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == foundTypeName);
				object tempObject = Activator.CreateInstance( type, new object[] {temp, Guid.NewGuid( ).ToString() } );

				if (type != null)
				{
					var groupedShapes = new List<ShapeBase>();
					if (foundTypeName == temp.GetType( ).Name && item[shapesKey].HasValues)
					{
						groupedShapes = DeserializeShapes(item[shapesKey].ToList( ));
						item.Remove(shapesKey);
					}
					object shape = JsonConvert.DeserializeObject(item.ToString(), type);
					if (shape is Group g && groupedShapes.Any( ))
						g.Shapes = groupedShapes;
					if (shape != null) shapes.Add((ShapeBase) shape);
				}
			}

			return shapes;
		}

		internal static string SerializeShapes(List<ShapeBase> shapes) => JsonConvert.SerializeObject(shapes, Formatting.Indented);

	}
}
