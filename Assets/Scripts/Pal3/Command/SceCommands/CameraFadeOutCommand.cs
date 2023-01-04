﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Command.SceCommands
{
    [AvailableInConsole]
    [SceCommand(69, "屏幕淡出")]
    public class CameraFadeOutCommand : ICommand
    {
        public CameraFadeOutCommand() { }
    }
}