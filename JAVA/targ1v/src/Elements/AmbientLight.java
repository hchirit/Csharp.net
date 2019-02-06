package Elements;

import java.awt.Color;
import java.util.Map;

/**
 * Created by HC on 06/05/2017.
 */
public class AmbientLight extends Light {
    private final double _Ka = 0.1;

    // ***************** Constructors ********************** //
    public AmbientLight(){
        super(new Color(255,255,255));
    }
    public AmbientLight(AmbientLight aLight){super(aLight.getColor());}
    public AmbientLight(int r, int g, int b){super(new Color(r,g,b));}


    // ***************** Getters/Setters ********************** //
    public Color getColor(){return this._color;}
    public void setColor(Color color){this.setColor(color);}
    public double getKa(){return this._Ka;}
    public Color getIntensity(){
        return new Color((int)(_color.getRed()   * _Ka),
            (int)(_color.getGreen() * _Ka),
            (int)(_color.getBlue()  * _Ka));}
}
