// This function translates the object(obj) so that it`s centre is always on the circular path

private void CircularTranslation(int degrees, int radius, Point centre)
{
    double radians = degrees * Math.PI / 180.0;

    // Calculate new coordinates
    double newX = centre.X - radius * Math.Cos(radians);
    double newY = centre.Y - radius * Math.Sin(radians);

    obj.Location = new Point((int)newX - (x-offset),(int)newY - (y-offset));
}

// Parameter Description
// degrees : It is the Angle of the object`s desired position from 0 which is to the left of the centre
// radius  : It is the radius of the circular path the object is to follow
// centre  : It is the location of the Centre of the Circular Path

// NOTE: This snippet is perfected and does not need any modifications