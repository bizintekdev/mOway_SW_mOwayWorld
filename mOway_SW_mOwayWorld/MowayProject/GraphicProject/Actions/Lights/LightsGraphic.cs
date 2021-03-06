﻿using System;
using System.Xml;
using System.Drawing;

using SdlDotNet.Graphics;

using Moway.Project.GraphicProject.GraphLayout;
using Moway.Project.GraphicProject.GraphLayout.Elements;

namespace Moway.Project.GraphicProject.Actions.Lights
{
    public class LightsGraphic : GraphModule
    {
        public override bool Selected
        {
            get
            {
                return base.Selected;
            }
            set
            {
                if (this.selected != value)
                {
                    this.selected = value;
                    if (this.selected)
                        this.Surface.Blit(new Surface(Lights.GraphicIconSelected));
                    else
                    {
                        this.Surface.Fill(GraphDiagram.TRASPARENT_COLOR);
                        this.Surface.Blit(new Surface(Lights.GraphicIcon));
                    }
                }
            }
        }

        public LightsGraphic(string key)
            : base(key)
        {
            this.needInit = System.Convert.ToBoolean(Lights.NeedInit);
            this.Surface.Blit(new Surface(Lights.GraphicIcon));
        }

        public LightsGraphic(string key, LightsAction element, Point center)
            : base(key, element, center)
        {
            this.needInit = System.Convert.ToBoolean(Lights.NeedInit);
            this.Surface.Blit(new Surface(Lights.GraphicIcon));
        }

        public LightsGraphic(string key, XmlElement elementData)
            : base(key)
        {
            this.needInit = System.Convert.ToBoolean(Lights.NeedInit);
            this.Surface.Blit(new Surface(Lights.GraphicIcon));
            foreach (XmlElement nodo in elementData)
            {
                switch (nodo.Name)
                {
                    case "position":
                        this.Center = new Point(System.Convert.ToInt32(nodo.ChildNodes[0].InnerText), System.Convert.ToInt32(nodo.ChildNodes[1].InnerText));
                        break;
                    case "properties":
                        this.element = new LightsAction(key, nodo);
                        break;
                    case "previous":
                        break;
                    case "next":
                        break;
                    default:
                        throw new GraphException("Error al crear GraphStart");
                }
            }
        }

        public override void EnableConnector(Connector connector)
        {
            this.Surface.Fill(GraphDiagram.TRASPARENT_COLOR);
            this.Surface.Blit(new Surface(Lights.GraphicIcon));
            base.EnableConnector(connector);
        }

        public override void DisableConnectors()
        {
            base.DisableConnectors();
            this.Surface.Fill(GraphDiagram.TRASPARENT_COLOR);
            this.Surface.Blit(new Surface(Lights.GraphicIcon));
        }

        public override GraphElement Clone()
        {
            return new LightsGraphic(this.key, (LightsAction)this.element.Clone(), this.Center);
        }
    }
}
