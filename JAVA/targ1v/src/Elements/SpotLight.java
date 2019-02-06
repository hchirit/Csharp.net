package Elements;

import Primitives.Point3D;
import Primitives.Vector;

import java.awt.*;

/**
 * Created by HC on 07/05/2017.
 */
public class SpotLight extends PointLight {
    private Vector _direction;

    // ***************** Constructor ********************** //
    public SpotLight(Color color, Point3D position, Vector direction, double kc, double kl, double kq){
        super(color,position,kc,kl,kq);
        this._direction=direction;
        this._direction.normalize();
    }

    // ***************** Getters/Setters ********************** //
    public Color getIntensity(Point3D point){
        Color pointColor = super.getIntensity(point);
        Vector l = getL(point);
        l.normalize();
        double k = Math.abs(_direction.dotProduct(l));

        if (k > 1)
            k = 1;

        return new Color((int)(pointColor.getRed()   * k),
                (int)(pointColor.getGreen() * k),
                (int)(pointColor.getBlue()  * k));
    }
}
