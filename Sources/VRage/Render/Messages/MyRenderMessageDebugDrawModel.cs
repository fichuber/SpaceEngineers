﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRageMath;

namespace VRageRender
{
    public class MyRenderMessageDebugDrawModel : IMyRenderMessage
    {
        public string Model;
        public MatrixD WorldMatrix;
        public Color Color;
        public bool DepthRead;

        MyRenderMessageType IMyRenderMessage.MessageClass { get { return MyRenderMessageType.Draw; } }
        MyRenderMessageEnum IMyRenderMessage.MessageType { get { return MyRenderMessageEnum.DebugDrawModel; } }
    }
}
