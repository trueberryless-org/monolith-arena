﻿using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("ATTACKS")]
public class Attack
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("ATTACK_TYPE")]
    public AttackType AttackType { get; set; }
}