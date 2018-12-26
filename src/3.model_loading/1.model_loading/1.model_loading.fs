#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture_diffuse1;
uniform sampler2D texture_specular1;
uniform sampler2D texture_normal1;
void main()
{    
    vec3 diffuse1 = vec3(texture(texture_diffuse1, TexCoords));
    vec3 specular1 = vec3(texture(texture_specular1, TexCoords));
    vec3 normal1 = vec3(texture(texture_normal1, TexCoords));
    FragColor = vec4(diffuse1,1.0);
}