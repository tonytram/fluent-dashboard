﻿namespace FluentDashboard.Domain.Common;
public interface IEntity { }

public interface IEntity<T> : IEntity
{
    T Id { get; set; }
}
