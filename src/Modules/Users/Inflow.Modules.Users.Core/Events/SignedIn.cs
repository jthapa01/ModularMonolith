﻿using System;
using Inflow.Shared.Abstractions.Events;

namespace Inflow.Modules.Users.Core.Events;

internal record SignedIn(Guid UserId) : IEvent;