using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.OOP___Fundamental_Priniciples
{
    public class A { }
    public class B { }
    public class C : A { }

    #region Composition
    interface IVisible
    {
        void Draw();
    }

    class Invisible : IVisible
    {
        public void Draw()
        {
            Console.Write("I won't appear.");
        }
    }

    class Visible : IVisible
    {
        public void Draw()
        {
            Console.Write("I'm showing myself.");
        }
    }

    interface ICollidable
    {
        void Collide();
    }

    class Solid : ICollidable
    {
        public void Collide()
        {
            Console.Write("Bang!");
        }
    }

    class NotSolid : ICollidable
    {
        public void Collide()
        {
            Console.Write("Splash!");
        }
    }

    interface IUpdatable
    {
        void Update();
    }

    class Movable : IUpdatable
    {
        public void Update()
        {
            Console.Write("Moving forward.");
        }
    }

    class NotMovable : IUpdatable
    {
        public void Update()
        {
            Console.Write("I'm staying put.");
        }
    }
    class GameObject : IVisible, IUpdatable, ICollidable
    {
        private readonly IVisible _visible;
        private readonly IUpdatable _updatable;
        private readonly ICollidable _collidable;

        public GameObject(IVisible visible, IUpdatable updatable, ICollidable collidable)
        {
            _visible = visible;
            _updatable = updatable;
            _collidable = collidable;
        }

        public void Update()
        {
            _updatable.Update();
        }

        public void Draw()
        {
            _visible.Draw();
        }

        public void Collide()
        {
            _collidable.Collide();
        }
    }

    #endregion
}