﻿using System.Drawing;
using TagsCloudContainerCore.Result;

namespace TagsCloudContainerCore.InterfacesCore;

// ReSharper disable once UnusedType.Global
public interface IBitmapHandler
{
    // ReSharper disable once UnusedMember.Global
    public Result<None> Handle(Bitmap bitmap, string outPath, string format);
}