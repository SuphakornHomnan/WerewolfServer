
/*
 * Werewolf Engine
 *
 * This is a werewolf game engine for REST access. It is primarily developed for CPE200 class at Computer Engineering, Chiang Mai University.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: pruetboonma@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DNWS.Werewolf 
{ 
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class ActionRole
    { 
        public int ActionId {get; set;}
        public Action Action {get; set;}
        public int RoleId {get; set;}
        public Role Role {get; set;}

    }
}