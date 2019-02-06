package Elements;

import Primitives.Point3D;
import Primitives.Vector;

import java.awt.*;

/**
 * Created by HC on 06/05/2017.
 */
public class DirectionalLight extends Light implements LightSource {
    private Vector _direction;

    // ***************** Constructors ********************** //
    public DirectionalLight(Color color, Vector direction){
        this._color=color;
        setDirection(direction);
    }

    // ***************** Getters/Setters ********************** //
    public Color getIntensity(Point3D point){return getIntensity();}
    public Vector getDirection(){return _direction;}
    public void setDirection(Vector direction){this._direction=direction;}
    public Vector getL(Point3D point){return getDirection();}

}
