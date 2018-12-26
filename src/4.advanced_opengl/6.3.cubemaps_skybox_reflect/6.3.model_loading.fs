#version 330 core
out vec4 FragColor;

in vec2 TexCoords;
in vec3 Normal;
in vec3 Position;

uniform vec3 cameraPos;

uniform sampler2D texture_diffuse1;
uniform sampler2D texture_specular1;
uniform sampler2D texture_normal1;
uniform sampler2D texture_height1;
uniform sampler2D texture_reflect1;

uniform samplerCube skybox;

void main()
{   
    vec3 diffuse1 = vec3(texture(texture_diffuse1, TexCoords));
    vec3 specular1 = vec3(texture(texture_specular1, TexCoords));
    vec3 normal1 = vec3(texture(texture_normal1, TexCoords));
    vec3 height1 = vec3(texture(texture_height1, TexCoords));
    vec3 reflect1 = vec3(texture(texture_reflect1, TexCoords));

    vec3 I = normalize(vec3(TexCoords,0.0)-cameraPos);
    vec3 R = reflect(I,normalize(Normal));
    vec3 res = vec3(texture(skybox, R));
    FragColor = vec4(res,1.0);
}