﻿namespace BookSwap.Common.Entities
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }
}
