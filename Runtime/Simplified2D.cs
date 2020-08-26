using UnityEngine;
using UnityEngine.UI;


namespace Simplify2D
{
    /// <summary>
    /// Hilfsklasse um den Einstieg in Unity zu erleichtern
    /// </summary>
    [RequireComponent(typeof(Image))]
    public abstract class Simplified2D : MonoBehaviour
    {
        /// <summary>
        /// Referenz auf den RectTransform
        /// </summary>
        private RectTransform rectTransform;

        /// <summary>
        /// Referenz auf die Image-Komponente
        /// </summary>
        private Image image;

        /// <summary>
        /// Die X-Koordinate des Objektes
        /// </summary>
        public float posX
        {
            get => rectTransform.position.x;
            set
            {
                Vector2 newPosition = transform.position;
                newPosition.x = value;
                rectTransform.position = newPosition;
            }
        }

        /// <summary>
        /// Die Y-Koordinate des Objektes
        /// </summary>
        public float posY
        {
            get => rectTransform.position.y;
            set
            {
                Vector2 newPosition = transform.position;
                newPosition.y = value;
                rectTransform.position = newPosition;
            }
        }

        /// <summary>
        /// Die X- und Y-Koordinate des Objektes als dimensionaler Vektor
        /// </summary>
        public Vector3 positon
        {
            get => transform.position;
            set
            {
                rectTransform.position = value;
            }
        }

        /// <summary>
        /// Die Breite des Objektes in Pixel
        /// </summary>
        public float width
        {
            get => rectTransform.rect.width;
            set
            {
                rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value);
            }
        }

        /// <summary>
        /// Die Höhe des Objektes in Pixel
        /// </summary>
        public float height
        {
            get => rectTransform.rect.height;
            set
            {
                rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, value);
            }
        }

        /// <summary>
        /// Die Farbe der Grafik (Sprite)
        /// </summary>
        public Color color
        {
            get => image.color;
            set
            {
                image.color = value;
            }
        }

        /// <summary>
        /// Die Grafik des Objektes (Sprite)
        /// </summary>
        public Sprite sprite
        {
            get => image.sprite;
            set
            {
                image.sprite = value;
            }
        }

        /// <summary>
        /// Die Rotation des Objektes (Z-Achse)
        /// </summary>
        public float rotation
        {
            get => rectTransform.rotation.eulerAngles.z;
            set
            {
                transform.rotation = Quaternion.Euler(0, 0, value);
            }
        }

        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
            image = GetComponent<Image>();
        }
    }
}
